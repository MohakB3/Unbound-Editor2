﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnboundEditor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("// Global Values\r\nlet windowHeight = 770;\r\nlet windowWidth = 1520;\r\n\r\n// In-Game " +
            "Values\r\nlet gravity = {0};\r\nlet friction = 0.7;\r\n\r\nlet platNum = {1};\r\nlet platf" +
            "orms = [];\r\n\r\n// Game Assets\r\nconst platform1 = new Image();\r\nplatform1.src = \'p" +
            "latform1.png\';\r\n\r\nconst platform2 = new Image();\r\nplatform2.src = \'platform2.png" +
            "\';\r\n\r\nconst platform3 = new Image();\r\nplatform3.src = \'platform3.png\';\r\n\r\nconst " +
            "char = new Image();\r\nchar.src = \'character.png\';\r\n\r\nconst key = new Image();\r\nke" +
            "y.src = \'key.png\';\r\n\r\nlet animFrame = 0;\r\nlet gate = [];\r\nfor (let i = 0; i < 8;" +
            " i++) {{\r\n  gate[i] = new Image();\r\n  gate[i].src = \"portal/\" + i + \".png\";\r\n}}\r" +
            "\n\r\n// Initialization Code\r\nwindow.onload = (event) => {{\r\n    keyObject.yVelocit" +
            "y++;\r\n    animatedObject();\r\n}};\r\n\r\n// Objects\r\nlet player = {{\r\n    x: {3},\r\n  " +
            "  y: {4},\r\n    xVelocity: 0,\r\n    yVelocity: 0,\r\n    jump : true,\r\n    height: {" +
            "5},\r\n    width: {6}\r\n}};\r\n\r\nlet keyObject = {{\r\n    x: {8},\r\n    y: {9},\r\n    xV" +
            "elocity: 0,\r\n    yVelocity: 0,\r\n    picked: false,\r\n    height: 86,\r\n    width: " +
            "216\r\n}};\r\n\r\nlet gateObject = {{\r\n    x:  {10},\r\n    y: {11},\r\n    xVelocity: 0,\r" +
            "\n    yVelocity: 0,\r\n    height: 100,\r\n    width: 100\r\n}}\r\n\r\nlet keys = {{\r\n    r" +
            "ight: false,\r\n    left: false,\r\n    up: false,\r\n}};\r\n\r\n// Creating the Global Ca" +
            "nvas\r\nfunction rendercanvas(){{\r\n    ctx.fillStyle = \"#F0F8FF\";\r\n    ctx.fillRec" +
            "t(0, 0, windowWidth, windowHeight);\r\n    ctx.clearRect(0, 0, canvas.width, canva" +
            "s.height);\r\n\r\n}}\r\n\r\n// Creating the Player\r\nfunction renderplayer(){{\r\n    ctx.f" +
            "illStyle = \"#3f4f59\";\r\n    ctx.fillRect((player.x)-player.width, (player.y)-play" +
            "er.height, player.width, player.height);\r\n    ctx.drawImage(char, (player.x)-pla" +
            "yer.width, (player.y)-player.height, player.width, player.height);\r\n}}\r\n\r\n// Cre" +
            "ating Objects\r\nfunction renderObjects() {{\r\n    {7}\r\n}}\r\n\r\n// Creating and Rende" +
            "ring the Platforms\r\nfunction createplat(){{\r\n    platforms.push(\r\n        {{\r\n  " +
            "      x: 0,\r\n        y: 750,\r\n        width: 1600,\r\n        height: 200\r\n       " +
            " }}\r\n    );\r\n    \r\n    {2}\r\n}}\r\n\r\nfunction renderplat(){{\r\n    ctx.fillStyle = \"" +
            "#222831\";\r\n    for (let ei = 0; ei < platNum; ei++) {{\r\n        ctx.fillRect(pla" +
            "tforms[ei].x, platforms[ei].y, platforms[ei].width-50,platforms[ei].height);\r\n  " +
            "      if(platforms[ei].width == 200 && platforms[ei].height == 50) {{\r\n         " +
            "   ctx.drawImage(platform1, platforms[ei].x, platforms[ei].y, platforms[ei].widt" +
            "h-50, platforms[ei].height);\r\n        }}\r\n        if(platforms[ei].width == 300 " +
            "&& platforms[ei].height == 50) {{\r\n            ctx.drawImage(platform2, platform" +
            "s[ei].x, platforms[ei].y, platforms[ei].width-50, platforms[ei].height);\r\n      " +
            "  }}\r\n        if(platforms[ei].width == 100 && platforms[ei].height == 20) {{\r\n " +
            "           ctx.drawImage(platform3, platforms[ei].x, platforms[ei].y, platforms[" +
            "ei].width-50, platforms[ei].height);\r\n        }}\r\n    }}\r\n}}\r\n\r\n// Input Handler" +
            "s\r\ndocument.addEventListener(\"keydown\", function(event) {{\r\n    if (event.code =" +
            "== \'KeyW\') {{\r\n        if(player.jump == false) {{\r\n            player.yVelocity" +
            " = -10;\r\n        }}\r\n    }}\r\n    if (event.code === \'KeyA\') {{\r\n        keys.lef" +
            "t = true;\r\n    }}\r\n    if (event.code === \'KeyD\') {{\r\n        keys.right = true;" +
            "\r\n    }}\r\n}});\r\n\r\ndocument.addEventListener(\"keyup\", function(event) {{\r\n    if " +
            "(event.code === \'KeyW\') {{\r\n        if(player.yVelocity < -2) {{\r\n            pl" +
            "ayer.yVelocity = -3;\r\n        }}\r\n    }}\r\n    if (event.code === \'KeyA\') {{\r\n   " +
            "     keys.left = false;\r\n    }}\r\n    if (event.code === \'KeyD\') {{\r\n        keys" +
            ".right = false;\r\n    }}\r\n}});\r\n\r\nfunction animationLoop() {{\r\n    animFrame++;\r\n" +
            "    if(animFrame == 8){{\r\n        animFrame = 0;\r\n    }}\r\n}}\r\n\r\n// Game Loop\r\nfu" +
            "nction loop() {{\r\n    // Object Animation\r\n    if(keyObject.y == {9}+10) {{\r\n   " +
            "     keyObject.yVelocity = -0.5;\r\n    }}\r\n    if(keyObject.y == {9}-10) {{\r\n    " +
            "    keyObject.yVelocity = 0.5;\r\n    }}\r\n\r\n    // Player Border Collision\r\n    if" +
            "(player.x <= 50) {{\r\n        player.x = 50;\r\n    }}\r\n\r\n    if(player.x >= 1517) " +
            "{{\r\n        player.x = 1517;\r\n    }}\r\n\r\n    // Vertical Movement\r\n    if(player." +
            "jump == false) {{\r\n        player.xVelocity *= friction;\r\n    }} \r\n    else {{\r\n" +
            "        player.yVelocity += gravity;\r\n    }}\r\n    player.jump = true;\r\n\r\n    // " +
            "Horizontal Movement\r\n    if(keys.left) {{\r\n        player.xVelocity = -5;\r\n    }" +
            "}\r\n    if(keys.right) {{\r\n        player.xVelocity = 5;\r\n    }}\r\n    \r\n    // Up" +
            "dating the y and x coordinates of the player\r\n    player.y += player.yVelocity;\r" +
            "\n    player.x += player.xVelocity;\r\n\r\n    // Updating the y and x coordinates of" +
            " the objects\r\n    keyObject.y += keyObject.yVelocity;\r\n    keyObject.x += keyObj" +
            "ect.xVelocity;\r\n\r\n    // Collision Detection\r\n    let i = -1;\r\n\r\n    for (let eh" +
            " = 0; eh < platNum; eh++) {{\r\n        if(platforms[eh].x < player.x && player.x " +
            "< platforms[eh].x + platforms[eh].width && platforms[eh].y < player.y && player." +
            "y < platforms[eh].y + platforms[eh].height){{\r\n            i = eh;\r\n        }}  " +
            " \r\n    }}\r\n\r\n    if (i > -1){{\r\n        player.jump = false;\r\n        player.y =" +
            " platforms[i].y;    \r\n    }}\r\n\r\n    // Object Pickup Detection\r\n    if(keyObject" +
            ".x < player.x && player.x < keyObject.x + keyObject.height && keyObject.y < play" +
            "er.y && player.y < keyObject.y + keyObject.width){{\r\n        keyObject.picked = " +
            "true;\r\n    }}\r\n\r\n    // Level Switch\r\n    if(gateObject.x < player.x && player.x" +
            " < gateObject.x + gateObject.height && gateObject.y < player.y && player.y < gat" +
            "eObject.y + gateObject.width && keyObject.picked == true){{\r\n        window.loca" +
            "tion.replace(\"credits.html\");\r\n    }}\r\n\r\n    // Object Rendering\r\n    rendercanv" +
            "as();\r\n    renderplayer();\r\n    renderplat();\r\n    renderObjects();\r\n}}\r\ncanvas=" +
            "document.getElementById(\"canvas\");\r\nctx=canvas.getContext(\"2d\");\r\nctx.canvas.hei" +
            "ght = windowHeight;\r\nctx.canvas.width = windowWidth;\r\ncreateplat();\r\n\r\nsetInterv" +
            "al(loop,22);\r\nsetInterval(animationLoop,22);\r\n")]
        public string defaultCode {
            get {
                return ((string)(this["defaultCode"]));
            }
        }
    }
}