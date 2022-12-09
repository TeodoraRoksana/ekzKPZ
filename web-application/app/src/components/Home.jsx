import React, { useEffect, useState } from "react";

export default function Home(){
    const url = "https://localhost:7017/";
    const [serverData, setData] = useState([]);

    useEffect(() => {
        fetch(url + "api/Patient").then(json => json.json())
                                  .then(data => setData(data));
    }, [])

    return (
        <table class="table table-bordered" style={{textAlign: "center"}}>
             <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Id</th>
                    <th scope="col">Name</th>
                    <th scope="col">Last name</th>
                    <th scope="col">Date of birth</th>
                    <th scope="col">Arrival date</th>
                    <th scope="col">Arrival time</th>
                </tr>
            </thead>
            <tbody>
                {
                    serverData.map(
                        (d, index) =>
                             <tr>
                                <td>{index + 1}</td>
                                <td>{d.id}</td>
                                <td>{d.name}</td>
                                <td>{d.lastName}</td>
                                <td>{d.dateOfBirth}</td>
                                <td>x</td>
                                <td>x</td>
                            </tr>
                    )
                }
            </tbody>
        </table>
    )
}