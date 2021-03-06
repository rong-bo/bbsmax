﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using MaxLabs.bbsMax.Settings;

namespace MaxLabs.bbsMax.Web.max_pages.admin
{
    public partial class tool_freememory : AdminPageBase
    {
        protected override BackendPermissions.Action BackedPermissionAction
        {
            get { return BackendPermissions.Action.Tool_FreeMemory; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (_Request.IsClick("free"))
            {
                MessageDisplay msgDisplay = CreateMessageDisplay();
                if (_Request.IsChecked("isread", MaxLabs.WebEngine.Method.Post, false))
                {
                    System.GC.Collect();
                }
                else
                {
                    msgDisplay.AddError("请仔细阅读说明提示，并在复选框上打钩后再点“立即整理内存”按钮");
                }
            }
        }
    }
}