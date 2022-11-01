# AnimeRecommendations

# Why?  We have Goals -  Why are we doing this?
What's the problem?  Requirements:

Laura knows about lots of anime and manga books (some of the books she owns). She would like the ability to recommend them to other people.
One of the things that we can do is ask a visitor what things they like so they can relate to relevant to anime genres.    
Once the anime genre would be identified, Laura would provide recommendations ordered by her personal rating.
Website to engage with https://myanimelist.net/

# What?  What do we have to do? -Functionality

Functionality for User to Add a new entry.
Need the ability to Specify  if an entry is Anime or Manga. Note: Most Animes are based on Manga Books.
Functionality to ask a visitor questions about what they like.
Functionality to Rate an entry.
Functionality to Update an entry.
Functionality to Delete an entry.
Funtionality to produce a list of entries.

# How?  How do we do what we have to do?

Need an API to perform CRUD operations on entries.
Need Data Store to hold entries.

First card:
Create one endpoint to Add an entry. (Consideration for two endpoints - decision to have one based on anime and manga having many common properties)
