# Authorize For Asp.net MVC 

In this app you can check every function or view in asp.net mvc controller in order to check has access to it or not.

## Insert This simple code above yout controller to redirect every access to your AuthorizeAttribute


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmlakModel;
using DataAccess;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace AmlakPrice.Controllers
{
   
[CustomAuthorizeMVC]
    public class ProfileController : Controller
    {
    }
