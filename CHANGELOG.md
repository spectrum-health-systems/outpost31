<!-- u250829 -->

<div align="center">

  ![logo](https://github.com/spectrum-health-systems/tingen-web-service/blob/main/.github/img/logo/TngnWsvc-194x254.png?raw=true)
  ![logo](./.github/img/logo/TngnOpto-194x254.png)
  
  # CHANGELOGS

</div>

> **A note about this changelog file**  
> Since most of the development for the Tingen Web Service is actually done in Outpost31, this changelog is for both projects.

***

# Release 25.9

* `MODIFIED` The **AdminMode** functionality has been moved to the **Administration Module**
* `NEW` The **_aDeploy** command
* `NEW` The **_aRefresh** command
* `NEW` The **_aRegress** command
* `DEPRECIATED` AdminMode
* `NEW` Trace log limit value
* `NEW` The **Tingen_www\WebService** and **Tingen_Data\WebService** base folders are now defined in Web.config
* `NEW` Session data now includes the current day/time when the Tingen Web Service is executed


<details>
  <summary>Development notes</summary>

* Improved the logging functionality
  * Trace logs now have a *level* and a global *limit*. This allows you to specify what trace logs are created, and in turn the volume of trace logs that are created.
  
* Updating the administrative functionality
* Renaming variables to be more descriptive
* Updating XML documentation (and therefore API documentation)

* Misc
  * There are a bunch of logs in TingenWebService.asmx.cs that are for debugging use, and I've worked to reduce the
  amount of space they take up. I want them to be in the code, since they are helpful during development, but at the
  same time, I don't want them to be distracting.
  * Removed the popup when the Tingen Web Service is disabled, since that would actually cause havoc. Instead, a critical log is written.
  * Renamed variables to be more descriptive (e.g., "origOptObj" -> "originalOptionObject)
  * Moved all blueprint files to AppData\Blueprint. This way they are all in the same location, making it easier to find specific files. While blueprint files are less organized, since they are rarely touched, I think the trade off is worth it.
    * Standard blueprint files have a**.bp** extension
    * Embedded blueprint files have a **.embp** extension
  * Updated XML documentation (and therefore API documentation)

- [ ] Get current date when service starts


</details>

<br>

# Release 25.8

* `NEW` The **AdminMode**
* `NEW` The **Deploy** AdminMode
* `NEW` The **Refresh** AdminMode
* `NEW` The **Regress** AdminMode
* `UPDATED` Code/comment cleanup

<details>
  <summary>Development notes</summary>

* Created **AdminMode**, defined in Web.config, to perform the following administrative functions:
  * **Deploy**  - Deploy a new instance of the Tingen Web Service
  * **Refresh** - Refresh the AppData contents
  * **Regress** - Regression tests

* Updating the logging functionality to include the following types of logs:
  * Critical
  * Trace
  * Debuggler
  * Error
  * Primeval

</details>

<br>

***

<br>

# Releases earlier than 25.8

No notes, sorry!