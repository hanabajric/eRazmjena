﻿
using eZamjena.Model;
using eZamjena.Model.Requests;
using eZamjena.Model.SearchObjects;
using eZamjena.Model.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZamjena.Services
{
    public interface IKorisnikService : ICRUDService<Korisnik,KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    { 
    
        Task<Model.Korisnik> Login (string username, string password);
        Task<LoggedUser> GetUserRole(string username, string password);
        Task<Korisnik> AdminUpdate(int id, AdminKorisnikUpdateRequest update);
        public List<Korisnik> GetOtherUsers(int excludingUserId);

    }
}
