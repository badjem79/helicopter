# Source code for CS50’s Introduction to Game Development
https://cs50.harvard.edu/games/2018/weeks/8/

# Objectives

* Add Gems to the game that spawn in much the same way as Coins, though more rarely so. Gems should be worth 5 coins when collected and despawn when off the left edge of the screen.
* Fix the bug whereby the scroll speed of planes, coins, and buildings doesn’t reset when the game is restarted via the space bar.

# Specification
* Add Gems to the game that spawn in much the same way as Coins, though more rarely so. Gems should be worth 5 coins when collected and despawn when off the left edge of the screen. We have all of the pieces for this already implemented in the Coin and CoinSpawner classes, so it should suffice simply to make some new classes for the Gem and GemSpawner behaviors! In the Proto resource pack included in the Assets folder, you’ll find a model for a gem you can use, but feel free to import your own! You’ll need to make a prefab, recall, that you can attach to the GemSpawner component, should you choose to implement it similarly to what’s in the distro. There are of course other ways to implement this behavior, so feel free to experiment with the software as a chance to learn it all the more thoroughly if curious (but if you do decide to place it somewhere more unorthodox, make extremely sure when you commit your code that the staff is able to find it relatively quickly)! Do remember to make Gems worth 5 coins instead of just 1, and ensure they’re more rare than Coins as well! Aside from that, they should behave identically to Coins, including moving automatically from right to left and despawning when past the left edge of the screen!
* Fix the bug whereby the scroll speed of planes, coins, and buildings doesn’t reset when the game is restarted via the space bar. This one’s a one-liner; note that static variables aren’t actually reset upon loading a scene, so a place to check would be the SkyscraperSpawner, as the speed field therein is what actually drives the speed for Skyscrapers, Airplanes, and Coins! However, we won’t find that this is the place where the game is reset upon pressing the space bar, and thus changing speed here doesn’t make much sense; any guesses as to where the code for resetting the game could be located?

# Video of the Demo
https://youtu.be/XXX