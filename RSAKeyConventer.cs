using System.Security.Cryptography;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using System.Text;

namespace 加密通话姬
{
    public class RSAKeyConverter
    {
        public struct RSASecretKey
        {
            public RSASecretKey(string privateKey, string publicKey)
            {
                PrivateKey = privateKey;
                PublicKey = publicKey;
            }
            public string PublicKey { get; set; }
            public string PrivateKey { get; set; }

            public string PublicKey_NoXml()
            {
                return FromXmlPublicKey(PublicKey);
            }
            public string PrivateKey_NoXml()
            {
                return FromXmlPrivateKey(PrivateKey);
            }

            public override string ToString()
            {
                return string.Format(
                    "PrivateKey: {0}\r\nPublicKey: {1}", PrivateKey, PublicKey);
            }
        }

        public static string RSAEncrypt(string xmlPublicKey, string content)
        {
            string encryptedContent = string.Empty;
            using (RSACryptoServiceProvider? rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(xmlPublicKey);
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
                encryptedContent = Convert.ToBase64String(encryptedData);
            }
            return encryptedContent;
        }

        public static string RSADecrypt(string xmlPrivateKey, string content)
        {
            string decryptedContent = string.Empty;
            using (RSACryptoServiceProvider? rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(xmlPrivateKey);
                byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(content), false);
                decryptedContent = Encoding.UTF8.GetString(decryptedData);
            }
            return decryptedContent;
        }

        /// <summary>
        /// generate RSA secret key
        /// </summary>
        /// <param name="keySize">the size of the key,must from 384 bits to 16384 bits in increments of 8 </param>
        /// <returns></returns>
        public static RSASecretKey GenerateRSASecretKey(int keySize)
        {
            RSASecretKey rsaKey = new RSASecretKey();
            using (RSACryptoServiceProvider? rsa = new RSACryptoServiceProvider(keySize))
            {
                rsaKey.PrivateKey = rsa.ToXmlString(true);
                rsaKey.PublicKey = rsa.ToXmlString(false);
            }
            return rsaKey;
        }

        /// <summary>
        /// xml private key -> base64 private key string
        /// </summary>
        /// <param name="xmlPrivateKey"></param>
        /// <returns></returns>
        public static string FromXmlPrivateKey(string xmlPrivateKey)
        {
            string result = string.Empty;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(xmlPrivateKey);
                RSAParameters param = rsa.ExportParameters(true);
                RsaPrivateCrtKeyParameters? privateKeyParam = new RsaPrivateCrtKeyParameters(
                    new BigInteger(1, param.Modulus), new BigInteger(1, param.Exponent),
                    new BigInteger(1, param.D), new BigInteger(1, param.P),
                    new BigInteger(1, param.Q), new BigInteger(1, param.DP),
                    new BigInteger(1, param.DQ), new BigInteger(1, param.InverseQ));
                PrivateKeyInfo privateKey = PrivateKeyInfoFactory.CreatePrivateKeyInfo(privateKeyParam);

                result = Convert.ToBase64String(privateKey.ToAsn1Object().GetEncoded());
            }
            return result;
        }

        /// <summary>
        /// xml public key -> base64 public key string
        /// </summary>
        /// <param name="xmlPublicKey"></param>
        /// <returns></returns>
        public static string FromXmlPublicKey(string xmlPublicKey)
        {
            string result = string.Empty;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(xmlPublicKey);
                RSAParameters p = rsa.ExportParameters(false);
                RsaKeyParameters keyParams = new RsaKeyParameters(
                    false, new BigInteger(1, p.Modulus), new BigInteger(1, p.Exponent));
                SubjectPublicKeyInfo publicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(keyParams);
                result = Convert.ToBase64String(publicKeyInfo.ToAsn1Object().GetEncoded());
            }
            return result;
        }

        /// <summary>
        /// base64 private key string -> xml private key
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string ToXmlPrivateKey(string privateKey)
        {
            RsaPrivateCrtKeyParameters? privateKeyParams = PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey)) as RsaPrivateCrtKeyParameters;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                RSAParameters rsaParams = new RSAParameters()
                {
                    Modulus = privateKeyParams.Modulus.ToByteArrayUnsigned(),
                    Exponent = privateKeyParams.PublicExponent.ToByteArrayUnsigned(),
                    D = privateKeyParams.Exponent.ToByteArrayUnsigned(),
                    DP = privateKeyParams.DP.ToByteArrayUnsigned(),
                    DQ = privateKeyParams.DQ.ToByteArrayUnsigned(),
                    P = privateKeyParams.P.ToByteArrayUnsigned(),
                    Q = privateKeyParams.Q.ToByteArrayUnsigned(),
                    InverseQ = privateKeyParams.QInv.ToByteArrayUnsigned()
                };
                rsa.ImportParameters(rsaParams);
                return rsa.ToXmlString(true);
            }
        }

        /// <summary>
        /// base64 public key string -> xml public key
        /// </summary>
        /// <param name="pubilcKey"></param>
        /// <returns></returns>
        public static string ToXmlPublicKey(string pubilcKey)
        {
            RsaKeyParameters? p = PublicKeyFactory.CreateKey(Convert.FromBase64String(pubilcKey)) as RsaKeyParameters;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                RSAParameters rsaParams = new RSAParameters
                {
                    Modulus = p.Modulus.ToByteArrayUnsigned(),
                    Exponent = p.Exponent.ToByteArrayUnsigned()
                };
                rsa.ImportParameters(rsaParams);
                return rsa.ToXmlString(false);
            }
        }
    }
}