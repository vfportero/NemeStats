NemeStats  
===============

NemeStats.com was created as a fun and completely free website for tracking games played and won among a fairly stable group of players. Recording your games will reveal each player's Nemesis (and their Minions), will assign Champions to games, and will provide many other interesting statistics.

NemeStats has a full-featured REST API which you are completely entitled to use as a back-end for your own site or application.
The API is currently at version 2. For more information on the REST API, check out the [Apiary documentation](http://docs.nemestatsapiversion2.apiary.io/#).

The site is actively being developed for fun and to brush up on the most recent .NET goodness. The code base is being constantly refactored in an effort to demonstrate "Clean Code" as preached by Uncle Bob Martin. We encourage constructive feedback, feature requests, or even pull requests if you'd like to add a feature yourself (but please TDD or at least unit test it :)).

The following GitHub projects and corresponding NuGet packages were spawned as a result of building NemeStats.com:
* [Universal Analytics for DotNet](https://github.com/RIDGIDSoftwareSolutions/Universal-Analytics-For-DotNet) - This is a .NET wrapper over Google's Universal Analytics Measurement Protocol and is used to push custom events to Universal Analytics from the server side.
* [Versioned REST API](https://github.com/RIDGIDSoftwareSolutions/versioned-rest-api) - This simple project allows us to easily handle versioning of the REST API via the url (e.g. /api/v2/Players).

If you are interested in contributing, check out [the contributors readme](https://github.com/NemeStats/NemeStats/blob/master/Constributors.md)

Catch us @nemestats or @jakejgordon on Twitter.
