# lab13-AsyncInn

This application utilizes MVC pracitces to create and make a front end to the back end database i created. the database contains multiple tables and properties of data in those tables that are all properly connected
clone the repo to your machine
open AsyncInn.SLN

CRUD


![ASyncInn](../../assets/AsyncInn2.PNG)

Hotel has a PK and references Hotel room
HotelRoom has a FK HotelID and FK roomID
Hotel room has a CK room number
Room has an ID and an Enum and references Room Amenities and HotelRoom
RoomAmenities has 2 dcomposite keys amenitiesID and ROOMID and references them both.
Amenities references roomAmenities and has a PK
