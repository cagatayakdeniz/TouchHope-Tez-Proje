using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;
using TouchHope.Entities.Dtos;

namespace TouchHope.WebAPI.Mapping.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AciliyetListDto, Aciliyet>();
            CreateMap<Aciliyet, AciliyetListDto>();

            CreateMap<CinsiyetListDto, Cinsiyet>();
            CreateMap<Cinsiyet, CinsiyetListDto>();

            CreateMap<IlListDto, Il>();
            CreateMap<Il, IlListDto>();

            CreateMap<KullaniciSignUpDto, Kullanici>();
            CreateMap<Kullanici, KullaniciSignUpDto>();
            CreateMap<KullaniciSignInDto, Kullanici>();
            CreateMap<Kullanici, KullaniciSignInDto>();
            CreateMap<KullaniciDto, Kullanici>();
            CreateMap<Kullanici, KullaniciDto>();
            CreateMap<KullaniciListHastaHayvanDto, Kullanici>();
            CreateMap<Kullanici, KullaniciListHastaHayvanDto>();
            CreateMap<KullaniciSignUpDto, Kullanici>();
            CreateMap<Kullanici, KullaniciSignUpDto>();
            CreateMap<KullaniciUpdateDto, Kullanici>();
            CreateMap<Kullanici, KullaniciUpdateDto>();

            CreateMap<KullaniciListDto, Kullanici>();
            CreateMap<Kullanici, KullaniciListDto>();

            CreateMap<TurListDto, Tur>();
            CreateMap<Tur, TurListDto>();
            CreateMap<TurAddDto, Tur>();
            CreateMap<Tur, TurAddDto>();
            CreateMap<TurUpdateDto, Tur>();
            CreateMap<Tur, TurUpdateDto>();

            CreateMap<BildirimListDto, Bildirim>();
            CreateMap<Bildirim, BildirimListDto>();
            CreateMap<BildirimAddDto, Bildirim>();
            CreateMap<Bildirim, BildirimAddDto>();

            CreateMap<IhbarListDto, Ihbar>();
            CreateMap<Ihbar, IhbarListDto>();
            CreateMap<IhbarAddDto, Ihbar>();
            CreateMap<Ihbar, IhbarAddDto>();

            CreateMap<HastaHayvanAddDto, HastaHayvan>();
            CreateMap<HastaHayvan, HastaHayvanAddDto>();
            CreateMap<HastaHayvanListDto, HastaHayvan>();
            CreateMap<HastaHayvan, HastaHayvanListDto>();

            CreateMap<RaporAddDto, Rapor>();
            CreateMap<Rapor, RaporAddDto>();
            CreateMap<RaporUpdateDto, Rapor>();
            CreateMap<Rapor, RaporUpdateDto>();
            CreateMap<RaporListDto, Rapor>();
            CreateMap<Rapor, RaporListDto>();
            CreateMap<RaporListHastaHayvanDto, Rapor>();
            CreateMap<Rapor, RaporListHastaHayvanDto>();

            CreateMap<SahiplendirilecekHayvanListDto, SahiplendirilecekHayvan>();
            CreateMap<SahiplendirilecekHayvan, SahiplendirilecekHayvanListDto>();
            CreateMap<SahiplendirilecekHayvanAddDto, SahiplendirilecekHayvan>();
            CreateMap<SahiplendirilecekHayvan, SahiplendirilecekHayvanAddDto>();

            CreateMap<KaybolanHayvanListDto, KaybolanHayvan>();
            CreateMap<KaybolanHayvan, KaybolanHayvanListDto>();
            CreateMap<KaybolanHayvanAddDto, KaybolanHayvan>();
            CreateMap<KaybolanHayvan, KaybolanHayvanAddDto>();

        }
    }
}
