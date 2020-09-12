
function Property(title, price, area, beds, baths, inputAddress, inputAddress2, inputCity, inputState, inputZip, image, description){
    this.title = title;
    this.price = parseFloat(price);   //because float
    this.area = parseInt (area);
    this.beds = parseInt (beds);
    this.baths = parseInt (baths);  //because integer
    this.inputAddress = inputAddress;
    this.inputAddress2 = inputAddress2;
    this.inputCity = inputCity;
    this.inputState = inputState;
    this.inputZip = inputZip;
    this.image = image;
    this.description = description;
}


function save() {
    //2get the text from the input
    //put them on variables
    let title = $("#title").val();
    let price = $("#price").val();
    let area = $("#area").val();
    let beds = $("#beds").val();
    let baths = $("#baths").val();
    let inputAddress = $("#inputAddress").val();
    let inputAddress2 = $("#inputAddress2").val();
    let inputCity = $("#inputCity").val();
    let inputState = $("#inputState").val();
    let inputZip = $("#inputZip").val();
    let image = $("#image").val();
    let description = $("#description").val();

    //3 create an object with the values that will be sent to the constructor
    var p = new Property( title, price, area, beds, baths, inputAddress, inputAddress2, inputCity, inputState,inputZip, image, description)

    console.log(p);


    //4 send the object on an AJAX request
    //POST
    // /catalog/registerProperty
    
    $.ajax({
        type: "POST",
        url: '/catalog/registerProperty',
        contentType: 'application/json',
        data: JSON.stringify(p),//specify the object
        success: res => {
            console.log("Survey says", res);

            // clear the form

            //document.getElementById("form-group").reset();

                        //copy the jquery here from above
                        $("#title").val();
                        $("#price").val();
                        $("area").val();
                        $("#beds").val();
                        $("#baths").val();
                        $("#inputAddress").val();
                        $("#inputAddress2").val();
                        $("#inputCity").val();
                        $("#inputState").val();
                        $("#inputZip").val();
                        $("#image").val();
                        $("#description").val();

            // show the message

            $("#alertSaved").removeClass('hide');

            setTimeout(
                () => $("alertSaved").addClass('hide'),
                5000
                );
        },
        error: details => {
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