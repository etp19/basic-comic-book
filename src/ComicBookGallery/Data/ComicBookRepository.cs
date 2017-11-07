﻿using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[] // array of objects
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>young Peter Parker returns home to live with his Aunt May. " +
                                  "Under the watchful eye of mentor Tony Stark, Parker starts to " +
                                  "embrace his new found identity as Spider-Man.</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name= "Dan Slott", Role = "Script"},
                    new Artist() {Name= "Humberto Ramos", Role = "Pencils"},
                    new Artist() {Name= "Victor Olazaba", Role = "Inks"},
                    new Artist() {Name= "Edgar Delgado", Role = "Colors"},
                    new Artist() {Name= "Chris Eliopoulos", Role = "Letters"},

                },
                Favorite = false

            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            }
        };

        public ComicBook[] GetComicBooks() // method to return an array of ComicBook objects.
        {
            return _comicBooks;
        }


        public ComicBook GetComicBook(int id) // method to return a ComicBook object.
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }

            return comicBookToReturn;
        }
    }
}