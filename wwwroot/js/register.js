
function Property(title, rooms, price){
    this.title = title;
    this.rooms = parseInt (rooms);  //because integer
    this.price = parseFloat(price);   //because float
}


function save() {
    //2get the text from the input
    //put them on variables



    let title = $("txtTitle").val();
    let rooms= $("#exampleFormControlSelect1").val();
    let price = $("price").val();
    //this.imageUrl = imageUrl;
    //this.description  = description
    

    //3create an object with the values
    var p = new Property( title, rooms, price)

    //4 send the object on an AJAX request
    //http.open("GET", "/catalog/registerProperty");
    //$.ajax({
   //     url: 'json-receive.php',
   //     type: 'post',
   //     data: {user: userStr},
   //     success: function(response)
  //  });

  $.ajax({
      type: "POST",
      url: 'catalog/registerProperty',
      contentType: 'application/json',
      data: JSON.stringify(p),
      success: (res) => {
          console.log("Servery says", res);

          // clear the form

          //document.getElementById("form-group").reset();

                    //copy the jquery here from above
                    $("txtTitle").val("");
                    $("#exampleFormControlSelect1").val("");
                    $("price").val("");

          // show the message

          $("#alertSaved").removeClass('hide');

          setTimeout(
            () => $("alertSaved").addClass('hide'),
            3000
            );
      },
      error: (details) => {
          console.log("Error", details);
      }
  });
}

function init() {
    console.log('Register page!');

    //1 - link click event to save  fn
    $("#btnSave").click(save);
}

window.onload = init;