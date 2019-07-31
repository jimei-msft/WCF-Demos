namespace WcfWebHttpService
{
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Echo(string message);

        // [WebGet()] is required for calling from the browser.
        [WebGet()]
        [OperationContract]
        string EchoFromBrowser(string message);
    }
}
