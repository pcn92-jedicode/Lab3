using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceXmlAndJsonDemo
{
    /// <summary>
    /// This interface contains the operation contracts.
    /// </summary>
    [ServiceContract]
    public interface IService1
    {
        #region OperationContracts

        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate="GetXml",ResponseFormat=WebMessageFormat.Xml,RequestFormat=WebMessageFormat.Xml,BodyStyle=WebMessageBodyStyle.Bare)]
        StudentXML GetStudentXML();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        StudentJSON GetStudentJSON();

        #endregion
    }
}
