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
    /// Implement the methods declared in the interface
    /// </summary>
    public class Service1 : IService1
    {
        #region ImplementedMethods

        public StudentXML GetStudentXML()
        {
            StudentXML xml = new StudentXML() {Name="Pavan",Id=1616,Salary=600 };
            return xml; ;
        }

        public StudentJSON GetStudentJSON()
        {
            StudentJSON json = new StudentJSON() {Name="Kumar",Id=1212,Salary=600 };
            return json;
        }

        #endregion
    }
}
