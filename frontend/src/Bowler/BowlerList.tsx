import { useEffect, useState } from 'react';
import { BowlerInfo } from '../types/BowlerInfo';
function BowlersList() {
  const [bowlerData, setBowlerData] = useState<BowlerInfo[]>([]);
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5226/BowlerInfo');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);
  return (
    <div>
      <div className="row">
        <h4 className="text-center">Bowlers on the Sharks and Marlins</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team Name </th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
export default BowlersList;
