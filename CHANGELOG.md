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

* `NEW` The **Administration Module**
* `NEW` Administrative commands: **_aDeploy**,  **_aRefresh**, and **_aRegress**
* `NEW` **traceLogLimit** setting
* `NEW` The **Tingen_www\WebService** and **Tingen_Data\WebService** base folders are now defined in Web.config
* `NEW` Session data now includes the current day/time, the Avatar UserName, and framework details
* `MODIFIED` The **AdminMode** functionality has been moved to the Administration Module
* `REMOVED` AdminMode
* `REMOVED` The popup that appears when the Tingen Web Service is disabled.

<details>
  <summary>Development notes</summary>

* The **AdminMode** functionality has been moved out of Web.config, and into new **Administration Module**,  
  allowing administrative functionality to be integrated into Avatar forms via ScriptLink events.

* Trace logs now have an individual **traceLevel** and a global **traceLevelLimit**, which allows you to specify  
  which trace logs are created. The **traceLevel** is defined on a per-log basis, and the **traceLevelLimit** is  
  defined in Web.config. A trace log is created when it's `traceLevel < traceLevelLimit`.

* Moved all blueprint files to AppData\Blueprint, making it easier to find specific files. While this is less  
  organized, blueprint files are rarely touched, so this will hopefully have little impact. Standard blueprint  
  files have a **.bp** extension, while embedded blueprint files have a **.embp** extension.

* Misc
  * Removed the popup when the Tingen Web Service is disabled, since that would actually cause havoc. Instead,  
    a critical log is written.






* Renaming variables to be more descriptive
* Updating XML documentation (and therefore API documentation)
  * There are a bunch of logs in TingenWebService.asmx.cs that are for debugging use, and I've worked to reduce the
  amount of space they take up. I want them to be in the code, since they are helpful during development, but at the
  same time, I don't want them to be distracting.


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