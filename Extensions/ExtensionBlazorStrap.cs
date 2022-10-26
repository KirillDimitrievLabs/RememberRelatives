using System.Runtime.CompilerServices;
using BlazorStrap;
using Microsoft.AspNetCore.Components.Web;
using static RemRelativesMaster.Pages.MyRelatives;

namespace RemRelativesMaster.Extensions
{
    //public static class ExtensionBlazorStrap
    //{
    //    public static void Test(this BSTR bstr)
    //    {
    //        bstr.IsActive = true;
    //    }
    //}
    public class BSTRWithOnHoverAnimation : BlazorStrap.BSTR
    {
        public bool GetIsActive(MouseEventArgs e)
        {
            return this.IsActive;
        }
    }
}
