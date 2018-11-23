	Feature: Navigate the Transavia.com website through the Homepage
	As a user and/or potential customer
    I want to be able to find the links I need on the homepage 
    So that I can go to any part of the website that I currently need

  
@Homepage @Destionations @Regression
Scenario: Homepage-001: Customer wants to know all the different destinations of Transavia.com
	Given a user is on the Transavia.com homepage
	When the user clicks on Bestemmingen in Secondary Menu
	Then the user sees the page with the title "Bestemmingen"
	
	   
@Homepage @Newsletter @Regression
Scenario: Homepage-002: Customer wants to register for the Newsletter
	Given a user is on the Transavia.com homepage
	When the user fills the field "Newsletter Subscription" with "Tester@mailinator.nl"
    And the user clicks on Aanmelden
	Then the user sees a confirmation of registration


	@Homepage @Booking @Regression
Scenario Outline: Homepage-003: Customer wants to find a flight
	Given a user is on the Transavia.com homepage
	When the user searches for a flight for 1 Volwassene Leaving from "<Vanaf>" To "<Naar>" on "<Vertrek>" and back on "<Return>" 
	Then the user sees the page with the title "Boek een vlucht"
	And the user can see Search Results

	Examples: 
	| No. of Persons | Vanaf                           | Naar                | Vertrek     | Return      |
	| 1 Volwassene   | Amsterdam (Schiphol), Nederland | Ljubljana, Slovenië | 15 dec 2018 | 29 dec 2018 |
	| 1 Volwassene   | Eindhoven, Nederland            | Alicante, Spanje    | 8 jan 2019  | 20 feb 2019 |



#The above scenarios have been automated using C#. Please take note, that because of anti-bot software, implicit waiting times of up to 15 seconds have been
#added to be able to manually take action. For example, completing the CAPTCHA-test. 


#Here under are Manual scenario's waiting to be automated.

#
#	@Homepage @Account @Regression
#Scenario: Homepage-004: Customer wants to create an account 
#	Given a user is on the Transavia.com homepage
#	When the user clicks on "Account Maken"
#	And the user fills the form correctly
#	Then the user sees the Verification Sent screen
#
#
#	@Homepage @Account @Regression
#Scenario: Homepage-005: Customer makes errors when creating an account
#	Given a user is on the Transavia.com homepage
#	When the user clicks on "Account Maken"
#	And the user fills the form incorrectly
#	Then the user sees feedback in the form of notification errors
#	And the user doesn't see the Verification Sent screen
#
#
#	@Homepage @Account @Regression
#Scenario: Homepage-006: Customer wants to check-in Online, but is too early
#	Given a user is on the Transavia.com homepage
#	When the user clicks on "Online Check-in"
#	And the user fills the required information to check-in correctly
#	And the user clicks on Inloggen
#	Then the user sees a notification that he cannot check-in yet
#
#
#	@Homepage @Regression
#Scenario: Homepage-007: Customer wants to Book an Hotel
#	Given a user is on the Transavia.com homepage
#	When the user clicks on "Boek een Hotel" 
#	Then the user sees the page with the title "Booking.com"
#
#
#		@Homepage @Flightstatus @Regression
#Scenario outline: Homepage-008: Customer wants to see the flight status of his upcoming flight and he doesn't have his flightnumber
#	Given a user is on the Transavia.com homepage
#	When the user clicks on "Vluchtstatus" in "Secondary Menu"
#    And fills in the Flightstatus form with "<Origin>" and "<Destination>"
#	And the user clicks on "Toon Vluchstatus" 
#	Then the user sees Flight details
#
#	Examples: 
#	| Origin		| Destination           | 
#	| Alicante      | Amsterdam (Schiphol)  | 
#
#
#	@Homepage @Flightstatus @Regression
#Scenario outline: Homepage-009: Customer wants to see the flight status of his upcoming flight and he does have his flightnumber
#	Given a user is on the Transavia.com homepage
#	When the user clicks on "Vluchtstatus" in "Secondary Menu"
#    And fills in the Flightstatus form with "<Flightnumber>"
#	And the user clicks on "Toon Vluchstatus" 
#	Then the user sees Flight details
#
#	Examples:
#	| Flightnumber	|           
#	| 12345			| 
