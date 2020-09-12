function fetchCatalog() {
    $.ajax({ 
        type:'GET',
        url: '/catalog/allProperties',
        success: res => {
            console.log(res);
            for(let i=0; i < res.length; i++) {
                displayProperty(res[i]);
            }
        },
        error: details => {
            console.log("Error", details);
        }
    });

}

function displayProperty(property) {
    //create the syntax
    var syntax = `<div class='item'>
        <h2 class = 'title'>${property.title}</h2>
    </div>`;

    //get container
    var container = $("#catalog-container");

    //append syntax to container

    container.append(syntax);

}

function init(){
    console.log("Catalog page!");

    fetchCatalog(); 
}

window.onload = init;



