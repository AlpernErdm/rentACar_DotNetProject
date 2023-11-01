using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç başarıyla eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";

        public static string CarUpdated = "Araç başarıyla güncellendi";
        public static string CarListed = "Araçlar listelendi";
        public static string MaintenanceTime = "Bakım arası";

        public static string AddedBrand = "Brand başarıyla eklendi";

        public static string NoDataInList = "Listede ürün yok";

        public static string NoDataOnFilter = "Filtreye uygun brand bulunmamaktadır";

        public static string AddedColor = "Renk Eklendi";

        public static string UpdatedColor = "Renk güncellendi";

        public static string DeletedColor = "Renk silindi";

        public static string AddedCustomer = "Müşteri Eklendi";

        public static string DeletedCustomer = "Müşteri Silindi";

        public static string ListedCustomers = "Müşteriler Listelendi";

        public static string UpdatedCustomer = "Müşteri güncellendi";

        public static string AddedRental = "Kiralama eklendi";

        public static string RemovedRental = "Kiralama silindi";

        public static string InvalıdRentalId = "Geçersiz RentalId ";

        public static string FilteredRental = "Geçerli Id listelendi";

        public static string UpdatedRental = "Geçerli Kiralama güncellendi";

        public static string ListedUsers = "Kullanıcılar Listelendi";

        public static string RemovedUser = "Kullanıcı slindi";

        public static string AddedUser = "Kullanıcı Eklendi";
    }
}
