namespace TPMDocs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spravoh.Справочник клиентов")]
    public partial class Справочник_клиентов
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Код { get; set; }

        [Column("Код ОКПО")]
        public double? Код_ОКПО { get; set; }

        [StringLength(15)]
        public string Номер { get; set; }

        [StringLength(15)]
        public string ИНН { get; set; }

        [Column("Наименование клиента")]
        [StringLength(255)]
        public string Наименование_клиента { get; set; }

        [Column("Краткое наименование клиента")]
        [StringLength(255)]
        public string Краткое_наименование_клиента { get; set; }

        [Column("Тип предприятия")]
        public int? Тип_предприятия { get; set; }

        [Column("Почтовый индекс")]
        [StringLength(6)]
        public string Почтовый_индекс { get; set; }

        [Column("Код страны")]
        [StringLength(3)]
        public string Код_страны { get; set; }

        [Column("Код области")]
        [StringLength(5)]
        public string Код_области { get; set; }

        [StringLength(60)]
        public string Адрес { get; set; }

        [Column("Код ж/д")]
        public int? Код_ж_д { get; set; }

        [Column("Код станции")]
        public int? Код_станции { get; set; }

        [Column("Код клиента по ж_д")]
        public int? Код_клиента_по_ж_д { get; set; }

        [Column("Ж_д ветка")]
        [StringLength(50)]
        public string Ж_д_ветка { get; set; }

        [Column("Код ж/д границы")]
        public int? Код_ж_д_границы { get; set; }

        [Column("Код станции границы")]
        public double? Код_станции_границы { get; set; }

        [Column("Код международной станции")]
        [StringLength(5)]
        public string Код_международной_станции { get; set; }

        [Column("Код междугородной станции")]
        [StringLength(5)]
        public string Код_междугородной_станции { get; set; }

        [StringLength(7)]
        public string Справочная { get; set; }

        [Column("Группа отраслей")]
        [StringLength(2)]
        public string Группа_отраслей { get; set; }

        [StringLength(4)]
        public string Отрасль { get; set; }

        [Column("Код экономиста")]
        public int? Код_экономиста { get; set; }

        [Column("Дата печати")]
        public DateTime? Дата_печати { get; set; }

        [Column("Дата редактирования")]
        public DateTime? Дата_редактирования { get; set; }

        public bool? Грузополучатель { get; set; }

        public bool? Плательщик { get; set; }

        [Column("Получатель платежа")]
        public bool? Получатель_платежа { get; set; }

        public bool? Поставщик { get; set; }

        [Column("Упак Применение")]
        public bool? Упак_Применение { get; set; }

        [Column("Упак ПостПризнак")]
        public int? Упак_ПостПризнак { get; set; }

        [Column("Упак ПостПричина")]
        public int? Упак_ПостПричина { get; set; }

        [Column("Упак ПостДопИнф")]
        [StringLength(100)]
        public string Упак_ПостДопИнф { get; set; }

        [Column("Упак ОбъемГод")]
        public double? Упак_ОбъемГод { get; set; }

        [StringLength(2550)]
        public string АдресГород { get; set; }

        [StringLength(15)]
        public string Телефон { get; set; }

        [StringLength(15)]
        public string Факс { get; set; }

        public bool? InUse { get; set; }

        public DateTime? CrDate { get; set; }

        [StringLength(50)]
        public string CrPC { get; set; }

        public bool? ПрФинОВЭС { get; set; }

        public bool? ПрСклад { get; set; }

        public int? Менеджер { get; set; }

        public bool? ВыборРазрешен { get; set; }

        public short? Статус { get; set; }

        public int? УсловиеID { get; set; }

        [Column("Старое наименование клиента")]
        [StringLength(255)]
        public string Старое_наименование_клиента { get; set; }

        public int? Группа { get; set; }

        public bool? ТТНБезЦены { get; set; }

        [StringLength(255)]
        public string ИмяКлиентУкр { get; set; }

        [StringLength(255)]
        public string ИмяКлиентВнутр { get; set; }

        public int? КодГруп { get; set; }

        [Column("Код продавца")]
        public int? Код_продавца { get; set; }

        public int? ДизайнерID { get; set; }

        public int? КонструкторID { get; set; }

        public int? КорпID { get; set; }

        public double? Рейтинг { get; set; }

        public double? ЛимитСумГрн { get; set; }

        public int? ПрНакл { get; set; }

        public int? ПрЦена { get; set; }

        public int? ПрДоп { get; set; }

        public int? ПрДоговор { get; set; }

        public int? ДопФлаг1 { get; set; }

        public int? ДопФлаг2 { get; set; }

        public int? ДопФлаг3 { get; set; }

        public bool? flFixSpec { get; set; }

        public int? Корпорация { get; set; }

        public int? ГородID { get; set; }
    }
}
