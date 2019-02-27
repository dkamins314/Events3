using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Events3.Models
{
    public class YearlyEvents
    {
        [Key]
        public int Id { get; set; }
        public SpecialEvents SpecialEvents { get; set; }
        public Months Months { get; set; }
        public Parshios Parshios { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
    public enum SpecialEvents
    {
        [Display(Name = "Selichos")]
        Selichos,
       [Display(Name = "Rosh Chodesh")]
        RoshChodesh,
        [Display(Name = "Rosh Hashana")]
        RoshHashana,
        [Display(Name = "Fast of Gedaliah")]
        FastOfGedalia,
        [Display(Name = "Yom Hakipurim")]
        YomHaKippurim,
        [Display(Name = "Sukkos")]
        Sukkos,
        [Display(Name = "Shmini Atzeres ")]
        ShminiAtzeres,
        [Display(Name = "Simchas Torah")]
        SimchasTorah,
        Chanukah,
        [Display(Name = "Tenth of Teves")]
        TenthOfTeves,
        [Display(Name = "Tu B'shvat")]
        TuBishvat,
        [Display(Name = "Fast of Esther")]
        FastOfEsther,
        [Display(Name = "Purim Katan")]
        PurimKatan,
        Purim,
        [Display(Name = "Shushan Purim")]
        ShushanPurim,
        [Display(Name = "Bedikas Chametz")]
        BedikasChametz,
        [Display(Name = "Fast of the First Born")]
        FastOfTheFirstborn,
        Pesach,
        [Display(Name = "Pesach Sheni")]
        PesachSheni,
        [Display(Name = "Lag Ba'omer")]
        LagBaomer,
        Shovuos,
        [Display(Name = "Seventeenth of Tamuz")]
        SeventeenthOfTamuz,
        [Display(Name = "Ninth of Av")]
        NinthOfAv,
        [Display(Name = "Tu B'av")]
        TuBeAv,
        [Display(Name = "Parshas Shekalim")]
        ParshasShekalim,
        [Display(Name = "Parshas Zachor")]
        ParshasZachor,
        [Display(Name = "Parshas Para")]
        ParshasPara,
        [Display(Name = "Parshas Hachodesh")]
        ParshasHachodesh,
        [Display(Name = "Shabbos Hagadol")]
        ShabbosHagadol,
        [Display(Name = "Shabbos Mevarchim")]
        ShabbosMevarachim,
        [Display(Name = "Shabbos Rosh Chodesh")]
        ShabbosRoshChodesh,
        [Display(Name = "Shabbos Chazon")]
        ShabbosChazon,
        [Display(Name = "Shabbos Shuva")]
        ShabbosShuva
    }
    public enum Months
    {
        Tishrei = 1,
        Cheshvan,
        Kislev,
        Teves,
        Shvat,
        AdarI,
        AdarII,
        Nissan,
        Iyar,
        Sivan,
        Tamuz,
        Av,
        Elul
    }
    public enum Parshios
    {
        Bereshis = 1,
        Noach,
        Lech_Lecha,
        Vayera,
        Chayei_Sara,
        Toldos,
        Vayetzei,
        Vayishlach,
        Vayeshev,
        Miketz,
        Vayigash,
        Vayechi,
        Shemos,
        Vaera,
        Bo,
        Beshalach,
        Yitro,
        Mishpatim,
        Terumah,
        Tetzaveh,
        Ki_Tisa,
        Vayakhel,
        Pekudei,
        Vayikra,
        Tzav,
        Shmini,
        Tazria,
        Metzora,
        Achrei_Mos,
        Kedoshim,
        Emor,
        Behar,
        Bechukosai,
        Bamidbar,
        Nasso,
        Behaaloscha,
        Shlach,
        Korach,
        Chukas,
        Balak,
        Pinchas,
        Matot,
        Masei,
        Devarim,
        Vaeschanan,
        Eikev,
        ReEh,
        Shoftim,
        Ki_Seitzei,
        Ki_Savo,
        Nitzavim,
        Vayeilech,
        HaAzinu,
        VezoS_Haberakhah,
        Vayakhel_Pekudei,
        Tazria_Metzora,
        Achrei_Mos_Kedoshim,
        Behar_Bechukotai,
        Chukat_Balak,
        Matot_Masei,
        Nitzavim_Vayeilech
    }
}
