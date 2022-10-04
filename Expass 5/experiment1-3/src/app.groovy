package com.example

@RestController
class ThisWillActuallyRun {

    @GetMapping("/")
    String home() {
        return "Hello, World!"
    }

}