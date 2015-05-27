using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyilvLib
{
    public static class WebApi
    {
        public static string HostAddress { get { return /*"http://localhost.fiddler:5112"*/ "http://localhost:5112"; } }
    }
    public static class ControllerFormats
    {
        public static class GetAlapadatById
        {
            public const string ControllerFormat = "api/Alapadatok/{id}";
            public const string ControllerName = "GetAlapadatById";
            public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Alapadatok/" + id.ToString()); }
        }
        public static class GetCegadatokById
        {
            public const string ControllerFormat = "api/Cegadatok/{id}";
            public const string ControllerName = "ControllerGetCegadatokById";
            public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Cegadatok/" + id.ToString()); }
        }
        public static class GetDokumentumokById
        {
            public const string ControllerFormat = "api/Dokumentumok/{id}";
            public const string ControllerName = "ControllerGetDokumentumokById";
            public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Dokumentumok/" + id.ToString()); }
        }

        public static class GetAlapadatAll
        {
            public const string ControllerFormat = "api/Alapadatok/all";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class FindAlapadat
        {
            public const string ControllerFormat = "api/Alapadatok/find";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class UpdateAlapadat
        {
            public const string ControllerFormat = "api/Alapadatok/update";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class UpdateCegadatok
        {
            public const string ControllerFormat = "api/Cegadatok/update";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class UpdateDokumentumok
        {
            public const string ControllerFormat = "api/Dokumentumok/update";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class DeleteAlapadatById
        {
            public const string ControllerFormat = "api/Alapadatok/delete/{id}";
            public const string ControllerName = "DeleteAlapadatokById";
            public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Alapadatok/delete/" + id.ToString()); }
        }
        public static class DeleteCegadatokById
        {
            public const string ControllerFormat = "api/Cegadatok/delete/{id}";
            public const string ControllerName = "DeleteCegadatokById";
            public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Cegadatok/delete/" + id.ToString()); }
        }
        public static class DeleteDokumentumokById
        {
            public const string ControllerFormat = "api/Dokumentumok/delete/{id}";
            public const string ControllerName = "DeleteDokumentumokById";
            public static string ControllerUrl(int id) { return (WebApi.HostAddress + "/api/Dokumentumok/delete/" + id.ToString()); }
        }

        public static class Aremeles
        {
            public const string ControllerFormat = "api/aremeles";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class ImportCeg
        {
            public const string ControllerFormat = "api/importCeg";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
        public static class ImportDokumentum
        {
            public const string ControllerFormat = "api/importDokumentum";
            public static string ControllerUrl { get { return WebApi.HostAddress + "/" + ControllerFormat; } }
        }
    }
}
