# LoLAccountChecker

This tool will give you some information about your league of legends accounts and store them in a text file.

### How to use:
To add accounts, open the Accounts window and from there you can add a single account or import a text file with your account's username and password line-by-line in the following format:
``
username:password
``

Then, click on **Start** to start checking. Your account's should start appearing in the table, if not, verify the Accounts window to see the state of the account. You can stop whenever you want, and click **Start** again if you wanna resume.
 
You can also import and export checked accounts that you want to see later.

* Summoner name
* Level
* RP
* IP
* Champions
* Skins
* Rune Pages
* Email Status
* SoloQ Rank
* Date of Last Match Played

### Requirements:

 * [PvPNetConnect](https://github.com/madk/PVPNetConnect)

### Export
You can export your accounts to a JSON file (this way you can import it later), or by creating your own layout. Check [Custom Export](https://github.com/madk/LoLAccountChecker/blob/master/Custom%20Export.md) to see the variables and some examples.

Update : 
 When you import a txt file the selected region is applied to these account
 On the main window you can double-click on a row to open the view window