using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace TestCloudAnalysis;

public partial class Foo
{
    private static bool Validation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        return true;
    }
}