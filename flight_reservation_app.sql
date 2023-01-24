CREATE DATABASE `flight_reservation_app`;
CREATE TABLE `bookings` (
  `bookingID` int NOT NULL AUTO_INCREMENT,
  `bookingDate` varchar(100) NOT NULL,
  `bookingNum` int NOT NULL,
  `customerID` int NOT NULL,
  `flightNum` int NOT NULL,
  PRIMARY KEY (`bookingID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `customers` (
  `customerID` int NOT NULL AUTO_INCREMENT,
  `customerFname` varchar(100) NOT NULL,
  `customerLname` varchar(100) NOT NULL,
  `customerPhone` varchar(100) NOT NULL,
  `customerBookings` int NOT NULL,
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `flights` (
  `flightID` int NOT NULL AUTO_INCREMENT,
  `flightNum` int NOT NULL,
  `flightOrigin` varchar(100) NOT NULL,
  `flightDestination` varchar(100) NOT NULL,
  `departureDate` varchar(100) NOT NULL,
  `arrivalDate` varchar(100) NOT NULL,
  `customerNum` int NOT NULL,
  `maximumSeat` int NOT NULL,
  PRIMARY KEY (`flightID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;