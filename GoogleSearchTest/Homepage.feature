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