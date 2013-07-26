using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace jQueryValidateNativeUnobtrusiveMVCUnitTests
{
    // Inspired by http://blogs.teamb.com/craigstuntz/2010/09/10/38638/ 

    internal class FakeHttpContext : HttpContextBase
    {
        private readonly Dictionary<object, object> _items = new Dictionary<object, object>();
        public override IDictionary Items { get { return _items; } }
    }

    internal class FakeViewDataContainer : IViewDataContainer
    {
        private ViewDataDictionary _viewData = new ViewDataDictionary();
        public ViewDataDictionary ViewData { get { return _viewData; } set { _viewData = value; } }
    }

}
