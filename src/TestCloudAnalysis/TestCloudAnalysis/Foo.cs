using System.Net;

namespace TestCloudAnalysis;

public partial class Foo
{
    public void Call()
    {
        var webRequest = (HttpWebRequest)WebRequest.Create("http://localhost");

        webRequest.ServerCertificateValidationCallback += Validation;
    }
}
