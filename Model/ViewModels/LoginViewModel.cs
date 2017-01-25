using System.ComponentModel.DataAnnotations;

namespace Model.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Hãy nhập tên tài khoản")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}