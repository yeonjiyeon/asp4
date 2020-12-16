using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace DevCounter
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // 애플리케이션 시작 시 실행되는 코드
            //AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            // RouteConfig.RegisterRoutes(RouteTable.Routes);    
            
            // [1] 사이트 통계 1/3
            Application["CurrentVisit"] = 0; //현재 사용자
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            // [2] 사이트 통계 2/3
            Application.Lock();
            Application["CurrentVisit"] =
                Convert.ToInt32(Application["CurrentVisit"]) + 1;// 현재 사용자
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // [3] 사이트 통계 3/3
            Application.Lock();
            Application["CurrentVisit"] = (int)Application["CurrentVisit"] - 1;// 현재 사용자
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

    }
}