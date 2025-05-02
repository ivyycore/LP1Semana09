# Diagram UML for AnimalKingdom

```mermaid
---
title: Program AnimalKingdom
---

classDiagram
    class Dog {
        + Sound() string
    }

    class Cat {
        + Sound() string
    }

    class Bee {
        + Sound() string
    }

    class Bat {
        + Sound() string
    }

    class Animal {
        + Sound() string
    }

    class IMammal {
        <<interface>>
        +NumberOfNipples int
    }

    class ICanFly {
        <<interface>>
        +NumberOfWings int
    } 
    Animal <-- Cat
    Animal <-- Dog
    Animal <-- Bee
    Animal <-- Bat
    Dog ..> IMammal
    Cat ..> IMammal
    Bat ..> IMammal
    Bee ..> ICanFly
    Bat ..> ICanFly
    
```