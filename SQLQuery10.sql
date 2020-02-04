ALTER TABLE House_rent
ADD CONSTRAINT FK_Rent_house2
FOREIGN KEY (Location_id) REFERENCES Rent_house2(Location_id);