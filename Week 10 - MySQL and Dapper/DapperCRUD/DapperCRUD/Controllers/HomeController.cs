﻿using DapperCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUD.Controllers
{
    public class HomeController : Controller
    {
        public MovieDAL MovieDB = new MovieDAL();

        public IActionResult Index()
        {
            List<Movie> movies = MovieDB.GetMovies();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            Movie m = MovieDB.GetMovie(id);
            return View(m);
        }

        //This will show full details of what we intend to delete 
        // ask the user if they are sure they wish to do so 
        //This first action is for creating the view 
        public IActionResult Delete(int id)
        {
            Movie m = MovieDB.GetMovie(id);
            return View(m);
        }

        //Processing input from the view - commonly you'll be processing form input 
        public IActionResult DeleteFromDb(int id)
        {
            MovieDB.DeleteMovie(id);
            return RedirectToAction("index", "home");
        }

        //This action will display the view as well as pass the movie to the form 
        public IActionResult Edit(int id)
        {
            Movie m = MovieDB.GetMovie(id);
            return View(m);
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            MovieDB.UpdateMovie(m);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit2(int id)
        {
            Movie m = MovieDB.GetMovie(id);
            return View(m);
        }

        [HttpPost]
        public IActionResult Edit2(Movie m)
        {
            MovieDB.UpdateMovie(m);
            return RedirectToAction("Index", "Home");
        }

        //We're making a new model so we just need to display the view
        public IActionResult Create()
        {
            return View();
        }

        //This is where we process form input for our create form 
        [HttpPost]
        public IActionResult Create(Movie m)
        {
            m.Year = 1700;
            //ModelState Is Valid checks the model against its data annotations 
            //It returns if all rules are met
            //It returns if any rule is violated 

            if (ModelState.IsValid)
            {
                //If the model is good we will pass it to our DB and jump back to the index
                MovieDB.CreateMovie(m);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //If the model is bad we will return to the same page 
                return View(m);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
