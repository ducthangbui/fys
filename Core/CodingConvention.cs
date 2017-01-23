using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    //Identifier	            Case	    Example

    //Class	                    Pascal	    AppDomain           public class StreamReader { ... }
    //Enum type	                Pascal	    ErrorLevel
    //Enum values	            Pascal	    FatalError
    //Event	                    Pascal	    ValueChange         public event EventHandler Exited;
    //Exception class	        Pascal	    WebException 		Note: Always ends with the suffix Exception.
    //Read-only Static field	Pascal	    RedValue
    //Interface	                Pascal	    IDisposable         Note: Always begins with the prefix I.      public interface IEnumerable { ... }
    //Method	                Pascal	    ToString            public virtual string ToString();
    //Namespace	                Pascal	    System.Drawing      namespace System.Security { ... }
    //Parameter	                Camel	    typeName
    //Property	                Pascal	    BackColor           public int BackColor { get; set;}
    //Protected instance field	Camel	    redValue
    //Public instance field	    Pascal	    RedValue            Note   Rarely used. A property is preferable to using a public instance field.

    //Local Variables           Camel       countUser           Variables inside a method
    //Class Variables/Fields   _Camel      _fullName           Variables inside a class
    //ReadOnly Fields           Pascal
    //Const Fields              Pascal


    //Resource name convention:

    //module (first 3 letters)_lbl/war/err/inf/msg

    //com_lbl_          lbl = label
    //com_war_          war = warning
    //com_err_          err = error
    //com_inf_          inf = information
    //com_msg_          msg = message

    //example
    //usr_lbl_Username = "..."
    //usr_war_LostData = "..."
    //usr_err_NewUser = "..."
    //user_msg_NewUserSuccess = "..."

    class CodingConvention
    {
        #region Private Members

        //private string _administratorRoleName;
        //private string _fullName;

        #endregion

        #region Constructors
        public CodingConvention()
        {
            UserID = -1;
            PortalID = -1;
        }

        #endregion

        #region Public Properties

        public string Username { get; set; }
        public int UserID { get; set; }
        public int PortalID { get; set; }
        public bool IsSuperUser { get; set; }

        #endregion

        #region Private Methods
        private bool isAdminUser(string accessingUser)
        {
            if (accessingUser == null || UserID == -1)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Public Methods
        public bool IsInRole(string role)
        {
            //super users should always be verified.
            if (IsSuperUser)
            {
                return role != "Unverified Users";
            }

            return false;
        }
        #endregion
    }//end of class
}
