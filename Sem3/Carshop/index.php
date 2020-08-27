<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <?php require_once('./components/links.php'); ?>

        <title>AutoFOCUS</title>
    </head>

    <body>
        <?php require_once('./components/nav.php');  ?>
        <h2 class="text-center"> Danmarks største forhandler af eksotiske biler </h2>
        <div class="col-md-12 newcar-banner">
            <div class="col-md-12 row">
                <div class="col-md-8">
                <h3> Lamborghini URUS </h3>
                <p> Kom og prøv en tur i den helt nye URUS </p>
                <div class="col-md-8 offset-1 row">
                    <button class="btn btn-primary"> Forudbestil </button>
                    <button class="btn btn-warning"> Lease </button>
                </div>
                <div class="col-md-8 offset-1">
                    <a href="./products.php">Se vores udvalg </a>
                </div>
                </div>
                <div class="col-md-3">
                    <img class="banner-img" src="https://cdn.cnn.com/cnnnext/dam/assets/180912190921-01-lamborghini-urus-exlarge-169.jpg">
                </div>
            </div>
        </div>

        <div class="sub-banner">
            <br />  
            <div class="col-md-4 offset-2">
                
            </div>
            <div class="offset-3 col-md-6">
                <form action="#">
                    <div class="row">
                        <div class="col-md-10">
                            <h3> Tilmeld nyhedsbrev </h3>
                            <div class="row">
                                <div class="col-md-10">
                                <input class="form-control" placeholder="Email Adresse" type="text">
                                </div>
                                <button class="btn btn-primary"> Tilmeld </button>
                            </div>
                        </div>
                        <div class="col-md-2">
                            
                        </div>
                    </div>
                </form>
            </div>
            <br />
            <br />
            <br />
        </div>


        <?php require_once('./components/footer.php') ?>
    </body>
</html>