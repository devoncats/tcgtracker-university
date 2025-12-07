using System;
using System.Collections.Generic;
using System.Linq;

namespace TCGTracker.Core
{
    public class TCGTrackerService
    {
        private readonly TCGTrackerDBDataContext _db = new TCGTrackerDBDataContext();

        public User GetUserByUsername(string username)
        {
            User user = _db.Users.FirstOrDefault(u => u.Username == username);

            return user ?? throw new KeyNotFoundException("User not found");
        }

        public List<Card> GetCards()
        {
            return _db.Cards.ToList();
        }

        public void CreateCard(Card card)
        {
            _db.Cards.InsertOnSubmit(card);
            _db.SubmitChanges();
        }

        public List<Collection> GetCollectionByUser(string username)
        {
            return _db.Collections.Where(c => c.Username == username).ToList();
        }

        public void CreateCollection(Collection collection)
        {
            _db.Collections.InsertOnSubmit(collection);
            _db.SubmitChanges();
        }

        public void DeleteCollectionByCard(string username, int id)
        {
            var collection = _db.Collections.FirstOrDefault(c => c.Username == username && c.CardId == id) ?? throw new KeyNotFoundException("Card not found");

            _db.Collections.DeleteOnSubmit(collection);
            _db.SubmitChanges();
        }
    }
}