using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusNerdy.Model
{
    public class SysUser
    {
        private string _userID;
        private string _userName;
        private string _userGroupID;
        private string _userDescribe;
        private string _roleID;
        private string _roleType;
        private string _roleDescribe;
        private string _email;
        private System.Nullable<bool> _isUse;

        public string userID
        {
            get
            {
                return this._userID;
            }
            set
            {
                this._userID = value;
            }
        }

        public string userName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this._userName = value;
            }
        }


        public string groupID
        {
            get
            {
                return this._userGroupID;
            }
            set
            {
                this._userGroupID = value;
            }
        }
        public System.Nullable<bool> isUse
        {
            get
            {
                return this._isUse;
            }
            set
            {
                this._isUse = value;
            }
        }

        public string Description
        {
            get
            {
                return this._userDescribe;
            }
            set
            {
                this._userDescribe = value;
            }
        }

        public string RoleID
        {
            get
            {
                return this._roleID;
            }
            set
            {
                this._roleID = value;
            }
        }
        public string RoleType
        {
            get
            {
                return this._roleType;
            }
            set
            {
                this._roleType = value;
            }
        }

        public string RoleDescribe
        {
            get
            {
                return this._roleDescribe;
            }
            set
            {
                this._roleDescribe = value;
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }      
    }
}
