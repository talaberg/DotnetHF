using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyilvLib
{
    public static class WebApi
    {
        public static string HostAddress { get { return "http://localhost.fiddler:5112"/*"http://localhost:5112"*/; } }
    }
    public static class ControllerFormats
    {
        //TODO: bepakolni ide a controller format-okat
    }
    public static class ControllerGetAlapadatById
    {
        public const string ControllerFormat = "api/Alapadatok/{id}";
        public const string ControllerName = "GetAlapadatById";
        public static string ControllerUrl(int id) { return ( WebApi.HostAddress + "/api/Alapadatok/" + id.ToString()); }
    }
    public static class ControllerGetCegadatokById
    {
        public const string ControllerFormat = "api/Cegadatok/{id}";
        public const string ControllerName = "ControllerGetCegadatokById";
        public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Cegadatok/" + id.ToString()); }
    }
    public static class ControllerGetDokumentumokById
    {
        public const string ControllerFormat = "api/Dokumentumok/{id}";
        public const string ControllerName = "ControllerGetDokumentumokById";
        public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Dokumentumok/" + id.ToString()); }
    }

    public static class ControllerGetAlapadatAll
    {
        public const string ControllerFormat = "api/Alapadatok/all";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerFindAlapadat
    {
        public const string ControllerFormat = "api/Alapadatok/find";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerUpdateAlapadat
    {
        public const string ControllerFormat = "api/Alapadatok/update";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerUpdateCegadatok
    {
        public const string ControllerFormat = "api/Cegadatok/update";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerUpdateDokumentumok
    {
        public const string ControllerFormat = "api/Dokumentumok/update";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerDeleteAlapadatById
    {
        public const string ControllerFormat = "api/Alapadatok/delete/{id}";
        public const string ControllerName = "GetDeleteAlapadatokById";
        public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Alapadatok/delete/" + id.ToString()); }
    }
    public static class ControllerDeleteCegadatokById
    {
        public const string ControllerFormat = "api/Cegadatok/delete/{id}";
        public const string ControllerName = "GetDeleteCegadatokById";
        public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Cegadatok/delete/" + id.ToString()); }
    }
    public static class ControllerDeleteDokumentumokById
    {
        public const string ControllerFormat = "api/Dokumentumok/delete/{id}";
        public const string ControllerName = "GetDeleteDokumentumokById";
        public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Dokumentumok/delete/" + id.ToString()); }
    }

    public static class ControllerAremeles
    {
        public const string ControllerFormat = "api/aremeles";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerImportCeg
    {
        public const string ControllerFormat = "api/importCeg";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
    public static class ControllerImportDokumentum
    {
        public const string ControllerFormat = "api/importDokumentum";
        public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
    }
}
