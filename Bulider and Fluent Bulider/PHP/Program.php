<?php

class Car {
    public $engine;
    public $color;
    public $doors;

    public function show() {
        echo "Engine: {$this->engine}, Color: {$this->color}, Doors: {$this->doors}\n";
    }
}

class CarBuilder {
    private $car;

    public function __construct() {
        $this->car = new Car();
    }

    public function setEngine($engine) {
        $this->car->engine = $engine;
        return $this;
    }

    public function setColor($color) {
        $this->car->color = $color;
        return $this;
    }

    public function setDoors($doors) {
        $this->car->doors = $doors;
        return $this;
    }

    public function build() {
        return $this->car;
    }
}

// Client
$car = (new CarBuilder())
    ->setEngine("V8")
    ->setColor("Black")
    ->setDoors(4)
    ->build();

$car->show();

?>