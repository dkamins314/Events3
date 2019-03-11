using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Events3.Models;

namespace Events3.Models
{
    public class Enums
    {
        public enum SpecialEvents
        {
            [Display(Name = "Please Select Event")]
            SelectEvent,
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

        }
        public enum SpecialShabassos
        {
            [Display(Name = "Please Select Special Shabbos")]
            SelectSpecialShabbos,
            [Display(Name = "Parshas Shekalim")]
            ParshasShekalim,
            [Display(Name = "Shabbos Chol Hamoed")]
            ShabbosCholHamoed,
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
            [Display(Name = "Please Select Month")]
            SelectMonth,
            Tishrei,
            Cheshvan,
            Kislev,
            Teves,
            Shvat,
            AdarI,
            Nissan,
            Iyar,
            Sivan,
            Tamuz,
            Av,
            Elul,
            AdarII,
        }
        public enum Parshios
        {
            [Display(Name = "Please Select Parshas Hashavua")]
            SelectParsha,
            Bereshis,
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
            Matos,
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
            Sazria_Metzora,
            Achrei_Mos_Kedoshim,
            Behar_Bechukotai,
            Chukat_Balak,
            Matot_Masei,
            Nitzavim_Vayeilech
        }

        
        public enum LifeEvents
        {
            [Display(Name = "Please Select Life Event")]
            Select,
            Birth,
            [Display(Name = "Shalom Zachor")]
            ShalomZachar,
            Bris,
            Upshearen,
            BarMitzvah,
            Graduation,
            Siyum,
            Engagement,
            ShabbosKallah,
            Marriage,
            Anniversary,
            Death,
            Levaya

        }
    }
}
