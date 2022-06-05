using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //product
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımdadır.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 farklı ürün olabilir.";
        public static string ProductNameAlreadyExist="Bu isimde bir ürün zaten mevcut.";
        public static string ProductUpdated="Ürün güncellendi.";

        //category
        public static string CategoriesListed="Kategoriler listelendi.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";

        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered="User eklendi.";
        internal static string UserNotFound="User bulunamadı.";
        internal static string PasswordError="Şifre Hatalı";
        internal static string SuccessfulLogin="Giriş Başarılı";
        internal static string UserAlreadyExists="Kullanıcı zaten var.";
        internal static string AccessTokenCreated="Token oluşturuldu.";
    }
}
