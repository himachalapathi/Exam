<!DOCTYPE html>

<html >
<head>
    <script src = "https://unpkg.com/@reactivex/rxjs@5.3.0/dist/global/Rx.js" ></ script >
</ head >
< body >
    < script >
        var foo = Rx.Observable.create(function (observer) {
            console.log('Hello');
            observer.next(42);
        });

        foo.subscribe(function (x) {
            console.log(x);
        });
        foo.subscribe(function (y) {
            console.log(y);
        });
</script>
</body>
</html>