﻿using WootzJs.Mvc.Mvc.Views;

namespace WootzJs.Mvc.Mvc
{
    public class ViewContext
    {
        public ControllerContext ControllerContext { get; set; } 
        public ActionHelper Action { get; set; }
        public UrlHelper Url { get; set; }
        
        public ViewContext()
        {
            Action = new ActionHelper(this);
            Url = new UrlHelper(this);
        }
    }
}