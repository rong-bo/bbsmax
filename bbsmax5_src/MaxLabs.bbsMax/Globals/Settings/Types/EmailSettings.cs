﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Text;
using System.Collections.Generic;

namespace MaxLabs.bbsMax.Settings
{
	/// <summary>
	/// Email系统设置
	/// </summary>
	public class EmailSettings : SettingBase
	{
		public EmailSettings()
		{
            this.SendServers = new EmailSendServerCollection();
		}

        private bool m_EnableSendEmail = false;

        [SettingItem]
        public bool EnableSendEmail
        {
            get
            {
                if (m_EnableSendEmail == false || this.SendServers.Count==0)
                    return false;

                return true;
            }
            set
            {
                m_EnableSendEmail = value;
            }
        }

        [SettingItem]
        public EmailSendServerCollection SendServers
        {
            get;
            set;
        }

        //private int m_EmailIndentity;

        //[SettingItem]
        //public int EmailIndentity
        //{
        //    get { return m_EmailIndentity++; }
        //    set { m_EmailIndentity = value; }
        //}

		public override bool Serializable
		{
			get
			{
				return false;
			}
		}
	}
}