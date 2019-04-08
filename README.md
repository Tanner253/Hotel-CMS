# lab13-AsyncInn
![ASyncInn](/assets/AsyncInn2.PNG)

Hotel has a PK and references Hotel room
HotelRoom has a FK HotelID and FK roomID
Hotel room has a CK room number
Room has an ID and an Enum and references Room Amenities and HotelRoom
RoomAmenities has 2 dcomposite keys amenitiesID and ROOMID and references them both.
Amenities references roomAmenities and has a PK