On Model:
-------------
        public List<Flights> getFilteredConnection(string City)
        {
            fiteredConnectionList = flightsList.Where(x => x.Routes.Contains(City)).ToList();
            return fiteredConnectionList;
        }
      
     On Controller:
     -----------------
             [HttpGet]
        [Route ("api/flight/stop/{city}")]
        public List<Flights> getFilteredRoutes(string city)
        {
            return flight.getFilteredConnection(city);//שולח עיר לסינון
            
        }
        
      On HTML
      -----------
              function showFiltered() {
            cityOFstop = $("#Connection").val();
            ajaxCall("GET", `../api/Flight/stop/${cityOFstop}`, showFlightsSuccess, showFlightsSuccess)
        }
        
        On HTML DIVS:
        --------------
        עצירה ב: <input type="text" name="Dest" id="Connection"><br>
        
        
                <input type="button" value="הצג עם עצירות" id="ConButton" />
