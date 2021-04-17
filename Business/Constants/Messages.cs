using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt başarıyla gerçekleştirildi.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı kaydı mevcut.";
        public static string AccessTokenCreated = "Giriş yapıldı";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı.";
        public static string PasswordError = "Geçersiz parola";
        public static string SuccessfulLogin = "Bşarılı Giriş";
    }
}
