function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4 title">
        <h1 className="text-white">Bowler League</h1>
      </div>
      <div className="col subtitle">
        <h4 className="text-white">{props.title}</h4>
      </div>
    </header>
  );
}

export default Header;
