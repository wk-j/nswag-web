import React from "react";
import { render } from "react-dom";
import { ValuesClient } from "../generated/Api";

class App extends React.Component<{}, {}> {

    constructor(props) {
        super(props);

        var client = new ValuesClient("");
        client.getAll().then(rs => {
            console.log(rs)
        })
    }
    render() {
        return (
            <h1>Hello, world</h1>
        )
    }
}

var el = document.getElementById("root");
render(<App />, el);