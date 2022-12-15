using System.Security.Cryptography;
using System.Text;

CreateKeys();
//var publicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArZAtQf068RNtLNMj/4qZTda+YoxnwU6XHnu67CX1emeXhYxMZq+Rq3d0srQ6xxI9iFUwPL4BY0kmXKbbPOgWdteqQ4bry+5FIrZ7H3p0nyz3MFiocC8KpdPX6owSnzlal/uj2pduF+DANLj3K8VLhVkBp6/YJNut/lzWenF/Ccx5O157SDhsCpoSsXPN82zQe1puOHpjcZY8Z6HlHaaNDREZi8uJ8/XDadWk4WEJP5bLJGEENHHnvkpzM0zG+Dkt9SA1XJ2L8kl1zYQWBaEaQ1z8Izp38PsD7r2d4K6n7fxMl7Zrzf1BrN17mrf3ZfqfmM0eWxAbW3CYtHxVtrcGRQIDAQAB";
var privateKey = "MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCtkC1B/TrxE20s0yP/iplN1r5ijGfBTpcee7rsJfV6Z5eFjExmr5Grd3SytDrHEj2IVTA8vgFjSSZcpts86BZ216pDhuvL7kUitnsfenSfLPcwWKhwLwql09fqjBKfOVqX+6Pal24X4MA0uPcrxUuFWQGnr9gk263+XNZ6cX8JzHk7XntIOGwKmhKxc83zbNB7Wm44emNxljxnoeUdpo0NERmLy4nz9cNp1aThYQk/lsskYQQ0cee+SnMzTMb4OS31IDVcnYvySXXNhBYFoRpDXPwjOnfw+wPuvZ3grqft/EyXtmvN/UGs3Xuat/dl+p+YzR5bEBtbcJi0fFW2twZFAgMBAAECggEAMIG25FZtfqq7PGfWC7kkl0iI9OngpXndajuSRiVlscv54O0Q/THcOFuuVbNhKfnDELMeRBumL6Vl/0byxtbmUFh90VmH1PrGf6kYR/flWActHmnoyVGcXDQUiAyVt8JDu24soQ7pSesaTKHVEnqVXLM/byoJ8mMjAY/YsWe+5XG2GhuLVIArd7NYKrg76pVpz6RI/PfNU5Kr0/r97Dx6cpACJmImXEehMt0K5I30tvt1Ip1253XuLLI97P++RmQsoPCyoRf9Pv/XHtygr8zF5BmqJxqyw0T2GGOKgUcuBnu7I3140YlMtUYZTN1vLo4WYI2yOSQv/smRqsuAG8thEQKBgQDLYgOtGk0SqKwMRLE3xbkxRX3iX0j9QQVOe0UtoxiX/4Cdsrqx1cukuuBuksCEcCtL9qibGyNXG6lVMlj0aClVQecaCTW892fCgjZLGchfBKZyCMi58SnDhO8zQ/XouKpb8WKDFiCxpNe9d2x66yo4dShFqkBW9Hac5UHSXOosUwKBgQDadzbWOrqnfKuNlIExrGzWbqJWfseXHg+RalaKUPtUnLV8CcHH3ufLAtfysVj+1825dgc3/80sIglZDXPOASDbJPnhqQTgKGAFfwWRDRdS9yhkL/TuRpmay/Tzvdno5Fdzw3JuIIvpq7xpgi/6qbPgiH/28+w1SystAL8HafbwBwKBgQCD5DgGFbxNkVyhSBq01GBYd3w/RROMSJIsZvxhsBbO2z6JBdLUaJT7asUIb9qxCBzL0lVc4Kh2YNXbDh9pv/Kt+2LnG3nh5X9AQDj9UucB134pDVE+ZAp1ZMvKLxRVqwuvPEZqQ/tHuGK/16ZdwAtNOYy4QMQgn8Ab1wBsbxzdSQKBgFSmcNcdtomDYy3e5xiKSTnlcH23bjr96OZdn97Edj5Y4nGHjlCV7JbbKTXexi8pC4vbUfy+349EOP8KmV6vTT3c2/42ca8xtdMrXsrPmcQKBNqdQni5Xnd+pBF19OOq5r/ycXp+nfgTFVSEn3avHwXXnk3gQhx8XeR4L4z94DMtAoGAJjirC4QHOAuhEOKaVaS7nFPgFiofgr7ZX7pe3RRbgL1PAoHyYdmW+eq382kClZva/vzkVgGhCpOPkpH8LjNgoj5IZ4QyO22XHaVWiznyBxZjs8JU+R1CixoZ4fkWo1CFA4mjYmwVb5EpDg6zLCnM3ZIDfLDJRFwbFZ7nGKxYasY=";

var text = "HXfcRv8RAvLswzkORPC6+Ef5hM3CzjlWXUa7p+CAhazoqr2jNLd7cML2nDoMh3oiFdr1IU8y7nZry39MpkPSGe3t5Mr51bbahteY4SPx08tAXn0pfz/qIwKXQRmvjGIBwwmMVjfXZMmyEFf/EsyCXGSfTQQzweuGpJbA2QQTEmeTjjFLiVGlLQMiZQNmR2HXVQjKTlNH66NfRG6mZYTuxVUQZouq2TtBfzz2SdI7mLKfVaTbi+XiKdrCGGMt1UOjwmWhlT6ZK262OTj+p6PS/EZP5uwya+qxF0mcxe2n9L9fwd1JLxHWKwNRRMa3i8ID30mLAOFw5MqgyavaQBkDpg==";
var payload = Decrypt(privateKey, text);
Console.WriteLine(payload);
Console.ReadKey();

static string Decrypt(string privateKey, string encryted)
{
    using var rsa = RSA.Create();
    rsa.ImportPkcs8PrivateKey(Convert.FromBase64String(privateKey), out _);
    var encryptedPayload = Convert.FromBase64String(encryted);
    var decryptedPayload = rsa.Decrypt(encryptedPayload, RSAEncryptionPadding.OaepSHA256);
    return (new UTF8Encoding()).GetString(decryptedPayload);
}

static void CreateKeys()
{
    using var rsa = RSA.Create();
    byte[] privateKeyPkcs8 = rsa.ExportPkcs8PrivateKey();
    string privateKeyPkcs8Base64Encoded = Convert.ToBase64String(privateKeyPkcs8);
    byte[] publicKey = rsa.ExportSubjectPublicKeyInfo();
    string publicKeyBase64Encoded = Convert.ToBase64String(publicKey);
    Console.WriteLine("Public Key: " + publicKeyBase64Encoded);
    Console.WriteLine();
    Console.WriteLine("Private Key: " + privateKeyPkcs8Base64Encoded);
    Console.WriteLine();
}

/*
 const crypto = require("crypto");

const encrypter = async (cleanText, publicKey) => {
  const cryptoKey = await crypto.subtle.importKey(
    "spki",
    Buffer.from(publicKey, "base64"),
    { name: "RSA-OAEP", hash: { name: "SHA-256" } },
    false,
    ["encrypt"]
  );

  const encrypted = await crypto.subtle.encrypt(
    {
      name: "RSA-OAEP",
    },
    cryptoKey,
    Buffer.from(cleanText, "utf8")
  );
  encryptedPayloadBase64Encoded = Buffer.from(encrypted).toString("base64");
  console.log(encryptedPayloadBase64Encoded);
};

const key =
  "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArZAtQf068RNtLNMj/4qZTda+YoxnwU6XHnu67CX1emeXhYxMZq+Rq3d0srQ6xxI9iFUwPL4BY0kmXKbbPOgWdteqQ4bry+5FIrZ7H3p0nyz3MFiocC8KpdPX6owSnzlal/uj2pduF+DANLj3K8VLhVkBp6/YJNut/lzWenF/Ccx5O157SDhsCpoSsXPN82zQe1puOHpjcZY8Z6HlHaaNDREZi8uJ8/XDadWk4WEJP5bLJGEENHHnvkpzM0zG+Dkt9SA1XJ2L8kl1zYQWBaEaQ1z8Izp38PsD7r2d4K6n7fxMl7Zrzf1BrN17mrf3ZfqfmM0eWxAbW3CYtHxVtrcGRQIDAQAB";

encrypter("Merhaba123564+q@***", key);
 */