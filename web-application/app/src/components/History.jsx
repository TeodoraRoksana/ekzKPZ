import React, { useEffect, useState } from "react";

export default function History(){
    const url = "https://localhost:7017/";
    const [serverData, setData] = useState([]);

    useEffect(() => {
        fetch(url + "api/History").then(json => json.json())
                                  .then(data => setData(data));
    }, [])

    return (
        <table class="table table-bordered" style={{textAlign: "center"}}>
             <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Id</th>
                    <th scope="col">PatientID</th>
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
                                <td>{d.patientId}</td>
                                <td>{d.date}</td>
                                <td>{d.time}</td>
                            </tr>
                    )
                }
            </tbody>
        </table>
    )
}