# HS2_FuckThe50Check
This plugin bypasses the asset bundle filename less than 50 check.

Without this, any mods (in the code using their 50 check) which have asset name more than 49.unity3d will not work, text, for example: aaa.unity3d files will also not work.
This plugin will disable the check by returning true every time, tricking the game into thinking the names are always less than 50.unity3d

**Download:**  
* Download the latest `HS2_FuckThe50Check.zip` from https://github.com/Mantas-2155X/HS2_FuckThe50Check/releases  

**Installation:**  
* Unzip `HS2_FuckThe50Check.zip` into your game directory. If done correctly, in `BepInEx/plugins/2155X/` you should see `HS2_FuckThe50Check.dll`  
