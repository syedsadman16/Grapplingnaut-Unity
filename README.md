# Group Tracker


Group Tracker is an Android application that makes it easier to plan trips with friends. Users can join or create events, communicate in a group chat and share their location with each other. The map displays live locations of all members in the group to make it easier to meet up and plan their commute. If a user is lost, they can send out a notification to all group members which contains their location, battery percentage and other useful information. 

Developer: **Syed Sadman**


# Features
The app has the following features:

* [ ] User Profile
	* [X] Sign in and register  
	* [X] Users can set profile pictures and status
	* [ ] Edit profile information    

* [ ] Create and Join events
    * [X] View/Join list of events with persistence
    * [X] Create new events
    * [X] Edit events
    * [ ] Password protected 

* [ ] View Shared Map
    * [X] Display live location for all members on map
    * [X] Click to move map to specific user or location
    * [X] Show Notifications for users that need help
    * [ ] Send important information with notification
	* [ ] TBD

* [ ] Chat Window
	* [X] Multiple users can communicate 
	* [ ] Share media
	* [ ] Personal chats
	* [ ] TBD 


## Screenshots

<table>
  <tr>
    <td>Main event</td>
     <td>Basic Chat</td>
     <td>Shared Map</td>
  </tr>
  <tr>
    <td><img src="screenshots/main.png" width=270 height=480></td>
    <td><img src="screenshots/chat.png" width=270 height=480></td>
    <td><img src="screenshots/map.png" width=270 height=480></td>
  </tr>
 </table>


Demo for Maps Feature
***
<img src='screenshots/demo4.gif' title='Maps' width='' alt='Demo' /> 



## Notes
- Firebase - Does not support arrays directly since array index is always changing and firebase is a real time db.  Creates problems when multiple users doing operations, array index shifts. Instead, it creates list of objects
- Always remember to detach listeners when needed
- Bugs/Challenges moved to commit log for commit on 6/6/20


## Resources Used

Images 
https://stackoverflow.com/questions/36117882/is-it-possible-to-store-image-to-firebase-in-android
https://www.thecrazyprogrammer.com/2016/10/android-convert-image-base64-string-base64-string-image.html
https://demonuts.com/pick-image-gallery-camera-android/

Search event location
https://developers.google.com/places/android-sdk/autocomplete
https://www.youtube.com/watch?v=6Trdd9EnmqY
https://medium.com/skillhive/android-google-places-autocomplete-feature-bb3064308f05

Location
https://stackoverflow.com/questions/10311834/how-to-check-if-location-services-are-enabled
https://www.youtube.com/playlist?list=PLgCYzUzKIBE-SZUrVOsbYMzH7tPigT3gi
https://medium.com/@shubham9032/structure-for-group-chat-using-firebase-583a84d794c2
- Follow user location
https://stackoverflow.com/questions/44992014/how-to-get-current-location-in-googlemap-using-fusedlocationproviderclient

Notifications
https://developer.android.com/training/notify-user/build-notification
https://code.tutsplus.com/tutorials/android-o-how-to-use-notification-channels--cms-28616

Chat
https://www.scaledrone.com/blog/android-chat-tutorial/
https://blog.sendbird.com/android-chat-tutorial-building-a-messaging-ui/

UI Kits
https://www.uplabs.com/android

## License

    Copyright 2020 Syed Sadman

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.


