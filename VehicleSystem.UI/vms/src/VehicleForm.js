import React from 'react';

class VehicleForm extends React.Component {
    constructor(props) {
      super(props);
      this.state = {make: '', latitude: '', Longitude: ''};
  
      this.handleChange = this.handleChange.bind(this);
      this.handleSubmit = this.handleSubmit.bind(this);
      
    }
  
    handleChange(event) {
      if(event.target.name === 'make'){
        this.setState({make: event.target.value});
      }
      if(event.target.name === 'latitude'){
        this.setState({latitude: event.target.value});
      }
      if(event.target.name === 'longitude'){
        this.setState({longitude: event.target.value});
      }
    }
  
    handleSubmit(event) {
      
      const requestOptions = {
        method: 'POST', 
        // headers: {
        //  'Content-Type': 'application/json',
        // },
        body: JSON.stringify(this.state)
      };
  
      fetch('https://localhost:44323/vehicle/create', requestOptions)
       .then(response => response.json())
       .then(data => this.setState({ result: data.id }));
  
      event.preventDefault();
    }
  
    render() {
      return (
        <form onSubmit={this.handleSubmit}>
          <h3>Create Vehicle</h3>
          <table>
            <tr>
              <td>Make:</td>
              <td><input name='make' type="text" value={this.state.make} onChange={this.handleChange} /></td>
            </tr>
            <tr>
              <td>Latitude:</td>
              <td><input name='latitude'type="text" value={this.state.latitude} onChange={this.handleChange} /></td>
            </tr>
            <tr>
              <td>Longitude:</td>
              <td><input name='longitude'type="text" value={this.state.longitude} onChange={this.handleChange} /></td>
            </tr>
            <tr>
              <td>Result: <label value= {this.state.result}/></td>
            </tr>
          </table>
          <input type="submit" value="Submit" />
        </form>
      );
    }
}
export default VehicleForm;
